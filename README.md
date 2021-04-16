# exam-fxrateswidget.backend
FXRates API Backend

## API Endpoints
- `GET: /fxrates/{baseCurrency}`
  - List all exchange rates of given base currency
  
- `OPTIONS: /fxrates`
  - Provide list of available currencies. Used in widget currency dropdown selections.

## How to Run
1. `git clone https://github.com/jdparaan-git/exam-fxrateswidget.backend.git`
2. Open `FXRatesApp.sln` file in Visual Studio 2019.
3. Open `appsettings.json` and configure `ExchangeRates` api access settings
4. Press `F5` to run. It will automatically install all dependencies on first run.

## TODO: 
- Add unit tests
