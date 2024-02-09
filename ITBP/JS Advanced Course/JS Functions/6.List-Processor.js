function solve(input) {
    let removedResult = []
    let result = []
    for (let i = 0; i < input.length; i++) {
        let [command, word] = input[i].split(' ')
        if (command == "add") {
            result.push(word)
        }
        
        if (command == "remove") {

            for (let i = 0; i < result.length; i++) {
                if (result[i] == word) {
                    removedResult = result.splice(i, 1)
                }
            }
        }
        if (command == "print") {
            let resultString=""
           for (const iterator of result) {
            resultString+=iterator+','
           }
           resultString = resultString.slice(0, -1);
           console.log(resultString)
        }
    }
}

solve(['add pesho', 'add george', 'add peter', 'remove peter','print'])