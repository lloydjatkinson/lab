export function keyExists (key) {
    if (localStorage.getItem(key)) {
        return true;
    }

    return false;
}

export function setKeyValue (key, value) {
    localStorage.setItem(key, value);
}

export function getKeyValue (key) {
    return localStorage.getItem(key);
}

export function removeKeyValue (key) {
    localStorage.removeItem(key);
}

export function clearStorage () {
    localStorage.clear();
}
