function onWindowResized(dotNetObject, token, onResizedMethodName) {
    if (!dotNetObject || !onResizedMethodName) {
        return false;
    }

    const hanlder = function () {
        if (dotNetObject && onResizedMethodName) {
            dotNetObject.invokeMethod(
                onResizedMethodName,
                token,
                window.outerHeight,
                window.outerWidth
            );
        }
    }

    window.addEventListener('resize', debounce(hanlder), true);
    hanlder();

    return true;
}

function debounce(func, wait = 20, immediate = true) {
    let timeout;
    return function () {
        const context = this, args = arguments;
        const later = function () {
            timeout = null;
            if (!immediate) {
                func.apply(context, args);
            }
        };
        const callNow = immediate && !timeout;
        clearTimeout(timeout);
        timeout = setTimeout(later, wait);
        if (callNow) {
            func.apply(context, args);
        }
    };
}

window.app = Object.assign({}, window.app, {
    onWindowResized
})