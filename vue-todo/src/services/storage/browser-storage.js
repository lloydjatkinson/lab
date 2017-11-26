import {
    keyExists,
    getKeyValue,
    setKeyValue
} from './storage/browser-storage';

export function save(text) {
    setKeyValue('test', text);
}

