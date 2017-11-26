<template>
    <div id="app">
        <!-- <img src="./assets/logo.png"> -->

        <todo class="feature" />
    </div>
</template>

<script>
import Todo from './components/todo.vue'

export default {
    name: 'app',
    components: {
        Todo
    }
}
</script>

<style>
#app {
    font-family: 'Avenir', Helvetica, Arial, sans-serif;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    /* text-align: center; */
    color: #2c3e50;
    /* margin-top: 60px; */

}

.feature {
    margin-left: auto;
    margin-right: auto;
    width: 60%;
}
</style>