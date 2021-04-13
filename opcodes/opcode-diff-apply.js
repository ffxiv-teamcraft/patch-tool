const fs = require('fs');
const path = require('path');


const diff = require('./diff.json');
let ipcs = fs.readFileSync(path.join(__dirname, 'Ipcs.cs'), "utf8");

const version = '5.45 hotfix';

diff.forEach(entry => {
    entry.old.forEach((old, index) => {
        if (entry.new[index]) {
            const newOpcode = entry.new[index];
            const hexValue = newOpcode.slice(2);
            const formattedOpcode = `0x${hexValue.padStart(4, '0').toUpperCase()}`;
            ipcs = ipcs
                .replace(new RegExp(`${old},\\s*\\/\\/\\s*updated\\s(?!${version}).*`, 'gmi'), `${formattedOpcode}, // updated ${version}`)
                .replace(new RegExp(`0x${old.split('0x')[1].padStart(4, '0')},\\s*\\/\\/\\s*updated\\s(?!${version}).*`, 'gmi'), `${formattedOpcode}, // updated ${version}`);
        }
    });
})

fs.writeFileSync(path.join(__dirname, 'Ipcs_new.cs'), ipcs);
