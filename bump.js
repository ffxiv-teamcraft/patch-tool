// TODO Make this a parameter
const fileName = 'FishParameter.json';
const file = require(`./input/definitions/${fileName}`);
const fs = require('fs');

file.definitions = file.definitions.map(def => {
    if (def.index >= 3) {
        def.index += 1;
    }
    return def;
});

fs.writeFileSync(`./output/${fileName}`, JSON.stringify(file, null, 2));
