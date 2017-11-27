<template>
    <div>
        <h1>Tasks</h1>
        <div>
            {{ pendingCount }} / {{ totalCount }}
        </div>
        <div class="pending">
            <ul>
                <li v-for="(item, index) in pendingItems" v-bind:key="index">{{ item.title }}</li>
            </ul>
        </div>
        <hr />
        <div class="completed">
            <ul>
                <li v-for="(item, index) in completedItems" v-bind:key="index">{{ item.title }}</li>
            </ul>
        </div>
    </div>
</template>

<script>
import { keyExists } from '../services/storage/browser-storage';

export default {
    name: 'Todo',
    data () {
        return {
            item: 'Finish this component',
            items: [{
                title: 'Finish this component',
                category: 'green',
                completed: false
            }, {
                title: 'Do more things',
                category: 'yellow',
                completed: true
            }, {
                title: 'Do other things with a really long string to test the page layout - hopefully it will look OK?',
                category: 'default',
                completed: false
            }, {
                title: 'Some other item',
                category: 'yellow',
                completed: true
            }, {
                title: 'Some other item',
                category: 'yellow',
                completed: false
            }]
        }
    },
    computed: {
        pendingCount: function () {
            return this.items.filter(item => item.completed === false).length;
        },
        pendingItems: function () {
            return this.items.filter(item => item.completed === false);
        },
        completedItems: function () {
            return this.items.filter(item => item.completed);
        },
        totalCount: function () {
            return this.items.length;
        }
    },
    methods: {
        saveTodo: function () {

        }
    }
}
</script>

<style lang="scss" scoped>
    @import "../styles/palette.scss";

    .list-padding {
        li {
            padding: 10px;
        }
    }

    ul {
        list-style-type: none;
        padding: 0px;

        li {
            padding: 10px;
        }
    }

    .completed li {
        font-style: italic;
        text-decoration: line-through;
    }

    .completed li:nth-child(odd) {
        background-color: #F2F2F2;
    }

    .pending li:nth-child(odd) {
        background-color: #F2F2F2;
    }
</style>