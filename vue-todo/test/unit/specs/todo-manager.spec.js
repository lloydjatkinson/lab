import {
    keyExists, 
    setKeyValue,
    getKeyValue,
    removeKeyValue,
    clearStorage,
    test
} from '@/services/storage/browser-storage';
//import { save, load } from '@/services/'

describe('Serializing todo items', () => {
    it('should correctly serialize a single todo item', () => {
        expect(test(1, 2)).toBe(3);
    });
});