<template>
    <div>
        <table>
            <thead>
                <tr>
                    <!-- <th v-for="(step, index) in timeSteps.length" v-bind:key="step">{{ timeStepLabelCalculation(index) }}</th> -->
                    <th
                        v-for="(timeStep, index) in timeStepVariationCalculation(timeStepStart, timeStepIncrement, timeStepCount)"
                        v-bind:key="timeStep">
                        {{ timeStep }}</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td
                        v-for="(item, index) in timeSteps"
                        v-bind:key="index">
                        <div
                            v-bind:class="{ selected: item.selected }"
                            v-on:click="toggleSelectedItem(index)">
                        </div>
                    </td>
                </tr>
            </tbody>
        </table>
        <div>
            <p>{{ selectedTimeSteps.length }} selected timeSteps:</p>
            <ul>
                <!-- <li v-for="(item, index) in selectedTimeSteps" v-bind:key="index">{{ timeSteps[index] }}</li> -->
            </ul>
        </div>
        <button v-on:click="reactiveTest()">Change timestep start</button>
    </div>
</template>

<script>
// @ts-check

let temporaryViewModel = {
    timeStepStart: 1901,
    timeStepIncrement: 5,
    optionTimings: [
        false,
        true,
        false,
        false,
        true,
        false,
        true,
        true,
        true,
        false,
        true
    ]
};

export default {
    name: 'ComputedToggle',
    data () {
        return {
            timeSteps: [],
            timeStepStart: 0,
            timeStepIncrement: 0,
            timeStepCount: 0
        }
    },
    computed: {
        selectedTimeSteps () {
            return this.timeSteps.filter(timestep => timestep.selected);
        }
    },
    methods: {
        toggleSelectedItem (timestepIndex) {
            this.timeSteps[timestepIndex].selected = !this.timeSteps[timestepIndex].selected;
        },
        timeStepLabelCalculation (index) {
            return index === 0 ? this.timeStepStart : this.timeStepStart + index * this.timeStepIncrement
        },
        timeStepVariationCalculation (initialTimeStep, variation, numberOfTimeSteps) {
            let timeSteps = [];
            for (let i = 0; i < numberOfTimeSteps; i++) {
                timeSteps.push(initialTimeStep + i * variation);
            }

            return timeSteps;
        },
        reactiveTest () {
            this.timeStepStart = 2000;
        }
    },
    created () {
        this.timeStepStart = temporaryViewModel.timeStepStart;
        this.timeStepIncrement = temporaryViewModel.timeStepIncrement;
        this.timeStepCount = temporaryViewModel.optionTimings.length;

        this.timeSteps = temporaryViewModel.optionTimings.map((x, index, array) => {
            return {
                selected: x
                // value: this.timeStepVariationCalculation(this.timeStepStart, this.timeStepIncrement, array.length)[index]
            }
        });
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