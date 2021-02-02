const fs = require('fs');
const path = require('path');


const diff = require('./diff.json');
let ipcs = fs.readFileSync(path.join(__dirname, 'Ipcs.cs'), "utf8");

const version = '5.45';

diff.forEach(entry => {
  entry.old.forEach((old, index) => {
    ipcs = ipcs
      .replace(new RegExp(`${old},\\s*\\/\\/\\s*updated\\s*.*`, 'gmi'), `${entry.new[index]}, // updated ${version}`)
      .replace(new RegExp(`0x${old.split('0x')[1].padStart(4, '0')},\\s*\\/\\/\\s*updated\\s*.*`, 'gmi'),`${entry.new[index]}, // updated ${version}`);
  })
})

fs.writeFileSync(path.join(__dirname, 'Ipcs_new.cs'), ipcs);


