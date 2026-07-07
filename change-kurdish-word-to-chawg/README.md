# Kurdish Word to CHAWG

This repository contains a Sorani Kurdish stemming proof-of-concept (POC) and a small .NET console demo.

The console application reads Kurdish text from `KurdishStemmerDemo/input.txt`, stems it, and writes the result to `KurdishStemmerDemo/output.txt`.

## How to run

After downloading the project open second folder (`KurdishStemmerDemo`) then open terminal there and run:

```bash
dotnet run
```

## Project structure

- `GendeStemmer/` - the stemming library.
- `KurdishStemmerDemo/` - a console app demonstrating how to use the stemmer with `input.txt` / `output.txt`.

## Notes

The stemmer is intentionally grammatically ignorant (POC). Outputs are meant to be predictable and consistent for information retrieval tasks like indexing and full-text searching.

