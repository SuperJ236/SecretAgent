# SecretAgent

When converting the secret message to *Base64*, use below script.
```powershell
[Convert]::ToBase64String([System.Text.Encoding]::ASCII.GetBytes("secret message"))
```

**Example:**
```powershell
[Convert]::ToBase64String([System.Text.Encoding]::ASCII.GetBytes("piggy"))
```
The above example will produce:
```
cGlnZ3k=
```
