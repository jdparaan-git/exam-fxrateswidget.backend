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

If run sucessfully, it should open a browser page displaying data from exchangeratesapi.io site:

![image](https://user-images.githubusercontent.com/43879798/115036092-c68e5d80-9eff-11eb-8df6-146deadef20b.png)

## TODO: 
- Add unit tests
