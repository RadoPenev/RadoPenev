const expect  = import('chai').expect;
const sum  = require('./4.Sum-Of-Numbers');  // Adjust the path accordingly

describe('sum function', () => {
    it('should return 0 for an empty array', () => {
        const result = sum([]);
        expect(result).to.equal(0);
    });

    // Other test cases...
});