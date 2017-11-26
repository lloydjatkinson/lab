<template>
    <div>
        <h1>Tasks</h1>
        {{ keyExists }}
        <div>
            {{ pendingCount }} / {{ totalCount }}
        </div>
        <div class="pending">
            <ul>
                <li v-for="(item, index) in pendingItems" v-bind:key="index">{{ item.title }}</li>
            </ul>
        </div>
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
                title: 'Do other things',
                category: 'default',
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
        },
        keyExists: function () {
            return keyExists('12345test');
        }
    },
    methods: {
        saveTodo: function () {

        }
    }
}
</script>

<style scoped>
    ul {
        list-style-type: none;
        padding: 0px;
    }
    
    ul li {
        padding: 10px;
    }

    .completed li {
        font-style: italic;
        text-decoration: line-through;
    }

    .pending li:nth-child(odd) {
        background-color: #F2F2F2;
    }
</style>
