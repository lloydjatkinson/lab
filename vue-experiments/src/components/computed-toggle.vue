<template>
    <div>
        <p>You have selected {{ selected.length }}</p>
        <div v-for="(item, index) in items" v-bind:key="index">
            <button
                v-bind:class="{ selected: selected == item.selected }"
                v-on:click="selectValue(index)">
                {{ item.value }}
            </button>
        </div>
    </div>
</template>

<script>
export default {
    name: 'ComputedToggle',
    data () {
        return {
            items: [{
                value: 1000,
                selected: false
            }, {
                value: 2000,
                selected: false
            }, {
                value: 3000,
                selected: false
            }]
        }
    },
    computed: {
        selected: function () {
            return this.items.filter(item => item.selected)
        }
    },
    methods: {
        selectValue: function (itemIndex) {
            this.items[itemIndex].selected = !this.items[itemIndex].selected;
        }
    }
}
</script>

<style lang="scss" scoped>
    button {
        .selected {
            background-color: green;
        }
    }

    .selected {
        background-color: green;
    }
</style>
