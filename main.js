const fs = require('fs');
const path = require('path');
const cliProgress = require('cli-progress');
const _ = require('lodash');

const progress = new cliProgress.SingleBar({
    format: ' {bar} | {value}/{total}',
    hideCursor: true,
    barCompleteChar: '\u2588',
    barIncompleteChar: '\u2591',
    clearOnComplete: false,
    stopOnComplete: true
});

const walkSync = function (dir, filelist) {
    const files = fs.readdirSync(dir);
    filelist = filelist || [];
    files.forEach(function (file) {
        if (fs.statSync(dir + '\\' + file).isDirectory()) {
            filelist = walkSync(dir + '\\' + file, filelist);
        } else {
            filelist.push(path.join(dir, file));
        }
    });
    return filelist;
};


// TODO make this a parameter
const previous = 'G:\\WebstormProjects\\xivapi.com\\data\\SaintCoinach.Cmd\\2021.01.28.0000.0000\\raw-exd-all';
const update = 'G:\\WebstormProjects\\xivapi.com\\data\\SaintCoinach.Cmd\\2020.12.29.0000.0000\\raw-exd-all';

const deletedSheets = [];
const modifiedSheets = [];

const previousSheets = walkSync(previous);
const newSheets = walkSync(update);

progress.start(previousSheets.length, 0);

function getFirstRow(sheet) {
    const data = fs.readFileSync(sheet, 'utf-8');
    return data.split(/\r?\n/)[3].split(',');
}

previousSheets.forEach(fileName => {
    const previousHeaders = getFirstRow(fileName);
    const sheetName = fileName.replace(previous, '');
    const newSheet = newSheets.find(sheet => {
        return sheet.replace(update, '') === sheetName;
    });
    if (newSheet === undefined) {
        deletedSheets.push(sheetName);
    } else {
        const newHeaders = getFirstRow(newSheet);
        if (newHeaders.length !== previousHeaders.length) {
            modifiedSheets.push(sheetName);
        }
    }
    progress.increment();
});


console.log('### DELETED SHEETS');
console.log('Total : ' + deletedSheets.length);
_.uniq(deletedSheets.map(name => name.replace(/\.\w{2}\.csv/, ''))).forEach(sheet => {
    console.log(` - ${sheet}`);
});

console.log('### MODIFIED SHEETS');
console.log('Total : ' + modifiedSheets.length);
_.uniq(modifiedSheets.map(name => name.replace(/\.\w{2}\.csv/, ''))).forEach(sheet => {
    console.log(` - ${sheet}`);
});

console.log('### NEW SHEETS');
const addedSheets = _.uniq(newSheets.map(name => name.replace(/\.\w{2}\.csv/, ''))).filter(sheet => {
    const newName = sheet.replace(update, '');
    return !previousSheets.some(prev => {
        return prev.indexOf(newName) > -1;
    })
});
addedSheets.forEach(sheet => {
    console.log(` - ${sheet.replace(update, '')}`);
});
