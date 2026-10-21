# pas2-csharp-change-making

Find a minimum-count exact combination of positive integer denominations.

Part of **Pas2 Polyglot** by [1Pas2](https://github.com/1Pas2): independent small projects in PHP, Python, Go and C#. No runtime dependencies outside the language standard library. Initial version: 0.1.0.

## Requirements and installation

.NET SDK 10 / net10.0. Add a project reference to `src/Library.csproj` from your application. Optional packaging: `dotnet pack src/Library.csproj -c Release`. NuGet publication was not performed.

## Example

```csharp
using Pas2.ChangeMaking;

var result = ChangeMaking.Solve(6, [1, 3, 4]);
Console.WriteLine(result is null ? "impossible" : string.Join(",", result));
```

## API and limits

ChangeMaking.Solve(amount,denominations) uses dynamic programming with unlimited supplies and positive integer units. Returns a minimum-count combination, empty for zero, or null when impossible. Amount is bounded to 100000; ties favor earlier smaller denominations. No finite stock constraints or currency rules.

## Tests and example

From the repository root:

```sh
dotnet build src/Library.csproj -c Release
dotnet run --project tests/Tests.csproj -c Release
dotnet run --project examples/Examples.csproj -c Release
```

Tests use the standard library or a dependency-free executable check harness. A failing assertion exits nonzero. The example is self-contained and uses local in-memory or temporary data. CI runs the same checks on Linux. No registry releases, downloads, users or production deployments are claimed.

## Contributing

Open a focused issue or pull request with reproduction steps and a behavioral test. Run the commands above before submitting. Do not include credentials or private data in reports.

## Ecosystem

[Browse Pas2 projects](https://github.com/1Pas2?tab=repositories&q=pas2-). Each repository is usable independently. The earlier TypeScript series and this polyglot series have distinct repository names.

## License

[MIT](LICENSE) © 2026 1Pas2.

1Pas2
