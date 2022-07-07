function sideBarSetCookie(cname, cvalue, exdays, page = false, domain = null) {
    var expires = "";
    if (exdays !== null) {
        var d = new Date();
        d.setTime(d.getTime() + (exdays * 24 * 60 * 60 * 1000));
        expires = ";expires=" + d.toUTCString();
    }
    var cookie = cname + "=" + cvalue + expires + ";path=/";
    if (page === false) {
        var dom = domain === null ? window.location.hostname : domain;
        if (!dom.startsWith("localhost"))
            dom = "." + dom;
        cookie = cookie + ";domain=" + dom;
    }
    document.cookie = cookie;
}
$(function () {
    $("a[data-widget='pushmenu']").on("click", function (event) {
        var collapsed = $("body").hasClass("sidebar-collapse");
        sideBarSetCookie("adminlte-sidebar", !collapsed);
    });
});