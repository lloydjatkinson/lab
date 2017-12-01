<template>
    <div>
        <p>You have selected {{ selectedItems.length }}</p>
        <div v-for="(item, index) in items" v-bind:key="index">
            <button
                v-bind:class="{ selected: item.selected }"
                v-on:click="toggleSelectedItem(index)">
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
        selectedItems: function () {
            return this.items.filter(item => item.selected)
        }
    },
    methods: {
        toggleSelectedItem: function (itemIndex) {
            this.items[itemIndex].selected = !this.items[itemIndex].selected;
        }
    }
}
</script>

<style lang="scss" scoped>
    button {
        &.selected {
            background-color: green;
        }
    }
</style>