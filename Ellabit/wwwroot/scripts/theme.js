export function isDarkTheme() {
    if (window.matchMedia('(prefers-color-scheme: dark)').matches) {
        return true;
    } else {
        return false;
    }
}