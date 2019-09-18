window.resizeListener = {
    watchOnResize: function (dotnetHelper, mediaQuery) {

        console.log(mediaQuery);
        const resized = () => dotnetHelper.invokeMethodAsync('RaiseOnResized',
            window.matchMedia(mediaQuery).matches);

        window.onresize = resized;

        return true;
    }
};