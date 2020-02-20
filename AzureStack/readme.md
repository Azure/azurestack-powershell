   ## Run Generation
In this directory, run AutoRest:
> `autorest`

---
### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../readme.azurestack.md

input-file:
  - $(this-folder)/dummy.json

output-folder: $(this-folder)/toss/
```
