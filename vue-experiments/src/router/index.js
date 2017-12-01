import Vue from 'vue';
import Router from 'vue-router';
// import HelloWorld from '@/components/HelloWorld'
import ComputedToggle from '@/components/computed-toggle';

Vue.use(Router);

export default new Router({
    routes: [{
        path: '/',
        name: 'ComputedToggle',
        component: ComputedToggle
    }]
});