function foo() {
    let str = ""

    return {
        append: v => (str += v),
        removeStart: x => (str = str.slice(x)),
        removeEnd: x => (str = str.slice(0, -x)),
        print: () => console.log(str),
    }
}

let secondZeroTest = foo();

secondZeroTest.append('123');
secondZeroTest.append('45');
secondZeroTest.removeStart(2);
secondZeroTest.removeEnd(1);
secondZeroTest.print();


