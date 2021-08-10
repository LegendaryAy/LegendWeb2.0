// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const onscroll = (el, listener) => {
    el.addEventListener('scroll', listener)
}


let selectHeader = document.getElementById("header");
if (selectHeader) {
    const headerScrolled = () => {
        if (window.scrollY > 100) {
            selectHeader.classList.add('header-scrolled')
            selectHeader.classList.remove('bg')
        }
        else {
            selectHeader.classList.remove('header-scrolled')
            selectHeader.classList.add('bg')
        }
    }
    window.addEventListener('load', headerScrolled)
    onscroll(document, headerScrolled)
}