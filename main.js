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

function ignoreSheet(sheetName) {
    return sheetName.includes('\\custom') || sheetName.includes('\\quest') || sheetName.includes('\\warp') || sheetName.includes('\\dungeon')
}


// TODO make this a parameter
const previous = 'F:\\WebstormProjects\\xivapi.com\\data\\ffxiv-datamining-patches\\extracts\\5.2';
const update = 'F:\\WebstormProjects\\xivapi.com\\data\\ffxiv-datamining-patches\\extracts\\5.3';

const deletedSheets = [];
const modifiedSheets = [];

const previousSheets = walkSync(previous);
const newSheets = walkSync(update);

progress.start(previousSheets.length, 0);

function getFirstRow(sheet) {
    const data = fs.readFileSync(sheet, 'utf-8');
    return data.split(/\r?\n/)[3].split(',');
}

function getHeaders(sheet) {
    const data = fs.readFileSync(sheet, 'utf-8');
    return data.split(/\r?\n/)[2].split(',');
}

previousSheets.forEach(fileName => {
    if (!ignoreSheet(fileName)) {
        const previousFirstRow = getFirstRow(fileName);
        const sheetName = fileName.replace(previous, '');
        const newSheet = newSheets.find(sheet => {
            return sheet.replace(update, '') === sheetName;
        });
        if (newSheet === undefined) {
            deletedSheets.push(sheetName);
        } else {
            const newFirstRow = getFirstRow(newSheet);
            if (newFirstRow.length !== previousFirstRow.length) {
                const newHeaders = getHeaders(newSheet);
                const previousHeaders = getHeaders(fileName);
                const entry = {
                    name: sheetName,
                    changes: newHeaders.reduce((changes, newHeader, index) => {
                        if (previousHeaders[index] === newHeader) {
                            return changes;
                        }
                        if (previousHeaders[index - 1] === newHeader || previousHeaders[index] === undefined) {
                            return [
                                ...changes,
                                {
                                    label: 'Inserted',
                                    type: newHeader,
                                    index: index
                                }
                            ]
                        }
                        if (previousHeaders[index + 1] === newHeader) {
                            return [
                                ...changes,
                                {
                                    label: 'Removed',
                                    type: newHeader,
                                    index: index
                                }
                            ]
                        }
                        return changes;
                    }, [])
                };
                modifiedSheets.push(entry);
            }
        }
    }
    progress.increment();
});

if (process.argv.indexOf('--quiet') > -1) {
    return;
}

console.log('### DELETED SHEETS');
console.log('Total : ' + deletedSheets.length);
_.uniq(deletedSheets.map(name => name.replace(/\.\w{2}\.csv/, ''))).forEach(sheet => {
    console.log(` - ${sheet}`);
});

console.log('### MODIFIED SHEETS');
console.log('Total : ' + modifiedSheets.length);
_.uniq(modifiedSheets.map(sheet => {
    sheet.name = sheet.name.replace(/\.\w{2}\.csv/, '');
    return sheet;
})).forEach(sheet => {
    console.log(` - ${sheet.name}`);
    sheet.changes.forEach(change => {
        console.log(`    - ${change.label} #${change.index}: ${change.type}`);
    })
});

console.log('### NEW SHEETS');
const addedSheets = _.uniq(newSheets.map(name => name.replace(/\.\w{2}\.csv/, ''))).filter(sheet => {
    const newName = sheet.replace(update, '');
    return !ignoreSheet(newName) && !previousSheets.some(prev => {
        return prev.indexOf(newName) > -1;
    })
});
console.log('Total : ' + addedSheets.length);
addedSheets.forEach(sheet => {
    console.log(` - ${sheet.replace(update, '')}`);
});
