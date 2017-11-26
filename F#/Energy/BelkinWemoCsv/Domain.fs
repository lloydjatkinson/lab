namespace BelkinWemoCsv

module Domain =
    open System

    type DailyEnergyReading =
        { Device: string
          Date: DateTimeOffset
          TotalkWh: double
          AverageWatts: int }