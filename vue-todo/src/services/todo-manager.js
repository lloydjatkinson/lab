import {
    keyExists,
    getKeyValue,
    setKeyValue
} from './storage/browser-storage';

export function save (item) {
    setKeyValue('test', item);
}

export function load (item) {
    return getKeyValue(item);
}