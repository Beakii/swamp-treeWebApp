var app = new Vue({
    //el refers to the div ID that Vue will look for in the CSHTML file to start the Vue application
    el: '#navBar',
    data: {
        drawerToggle: false,
        menuItems: [
            { icon: 'home', title: 'Home', link: 'https://www.google.com/' },
            { icon: 'info', title: 'About', link: 'http://www.gooogle.com' },
            { icon: 'shopping_cart', title: 'Shop', link: 'google.com' },
            { icon: 'face', title: 'Sign Up', link: '/about' },
            { icon: 'lock_open', title: 'Sign In', link: '' }
        ],
        
    },

    methods: {
        linkTo: function (menuItems) {
            window.location.href = menuItems.link;
        }
    },
})