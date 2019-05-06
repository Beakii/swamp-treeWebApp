Vue.component('nav-bar',
    {
        template:
            `<nav>
            <v-toolbar dark>
                <v-toolbar-side-icon v-on:click.native="sideNav = !sideNav" class="hidden-sm-and-up"></v-toolbar-side-icon>
                    <v-toolbar-title>Plant-A-Tree-Co</v-toolbar-title>
                    <v-spacer></v-spacer>
                    <v-toolbar-items class="hidden-xs-only">

                    <v-btn flat v-for="item in menuItems" :key="item.title" active-class="highlighted">
                        <v-icon left>
                            {{ item.icon }}
                        </v-icon>
                        {{ item.title }}
                    </v-btn>

                </v-toolbar-items>
            </v-toolbar>
        </nav>`,

        data: function () {
            return {
                menuItems: [
                    { icon: 'home', title: 'Home', link: 'https://www.google.com/' },
                    { icon: 'info', title: 'About', link: 'http://www.gooogle.com' },
                    { icon: 'shopping_cart', title: 'Shop', link: 'google.com' },
                    { icon: 'face', title: 'Sign Up', link: '/about' },
                    { icon: 'lock_open', title: 'Sign In', link: 'home' }
                ],
                sideNav: false
            }
        },

        methods: {
            linkTo: function (menuItems) {
                window.location.href = menuItems.link;
            }
        }
    }
)

Vue.component('mobile-nav', {
    template:
    `<v-navigation-drawer clipped v-model="sideNav">
        <v-list>

            <v-list-tile v-for="item in menuItems" :key="item.title">
                <v-list-tile-action>
                <v-icon>{{ item.icon }}</v-icon>
            </v-list-tile-action>

            <v-list-tile-content>{{ item.title }}</v-list-tile-content>

            </v-list-tile>
        </v-list>
    </v-navigation-drawer>`,

    data: function () {
        return {
            menuItems: [
                { icon: 'home', title: 'Home', link: 'https://www.google.com/' },
                { icon: 'info', title: 'About', link: 'http://www.gooogle.com' },
                { icon: 'shopping_cart', title: 'Shop', link: 'google.com' },
                { icon: 'face', title: 'Sign Up', link: '/about' },
                { icon: 'lock_open', title: 'Sign In', link: 'home' }
            ],
            sideNav: false
        }
    },

    methods: {
        linkTo: function (menuItems) {
            window.location.href = menuItems.link;
        }
    }
})


var app = new Vue({
    el: '#layout',


})