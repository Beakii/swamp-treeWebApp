var app = new Vue({
    el: '#layout',
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