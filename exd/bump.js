try {
    const fileName = `${process.argv[2]}.json`;
    const file = require(`../input/definitions/${fileName}`);
    const fs = require('fs');

    file.definitions = file.definitions.map(def => {
        if (def.index >= +process.argv[3]) {
            def.index += 1;
        }
        return def;
    });

    fs.writeFileSync(`./output/${fileName}`, JSON.stringify(file, null, 2));

} catch (e) {
    console.log(`Usage: node bump.js <filename without json> <index from which to bump>. Example: node bump.js Leve 5`)
}
