<template>
    <div>
        <table>
            <thead>
                <tr>
                    <th v-for="step in timesteps.length" v-bind:key="step">{{ timestepStart + step}}</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td
                        v-for="(item, index) in timesteps"
                        v-bind:key="index">
                        <div
                            v-bind:class="{ selected: item.selected }"
                            v-on:click="toggleSelectedItem(index)">
                        </div>
                    </td>
                </tr>
            </tbody>
        </table>
    <p>You have selected {{ selectedItems }}</p>
    </div>
</template>

<script>
// @ts-check

let temporaryViewModel = {
    timestepStart: 1901,
    timestepIncrement: 1,
    optionTimings: [
        true,
        true,
        true,
        true,
        true,
        true,
        true,
        true,
        true,
        true
    ]
};

export default {
    name: 'ComputedToggle',
    data () {
        return {
            timesteps: [],
            timestepStart: 0,
            timestepIncrement: 0
        }
    },
    computed: {
        selectedItems: function () {
            return this.timesteps.filter(timestep => timestep.selected);
        }
    },
    methods: {
        toggleSelectedItem: function (timestepIndex) {
            this.timesteps[timestepIndex].selected = !this.timesteps[timestepIndex].selected;
        }
    },
    created () {
        this.timesteps = temporaryViewModel.optionTimings.map((x) => {
            return {
                selected: false,
                value: x
            }
        });
        this.timestepStart = temporaryViewModel.timestepStart;
        this.timestepIncrement = temporaryViewModel.timestepIncrement;
    }
};
</script>

<style lang="scss" scoped>
button {
  &.selected {
    background-color: green;
  }
}

.selected {
        background-color: #5cb85c;
}

td div {
    min-width: 60px;
    min-height: 30px;
    background-color: #ddd;
    border: 1px solid transparent;
    border-color: #767676;
}
</style>