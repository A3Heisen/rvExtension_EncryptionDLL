# rvExtension_EncryptionDLL

A extension for Real Virtual Reality Engine 4 for Armed Assault 3 (Arma 3 ) to allow users to encrypt their desired string with optional
encryption algorithms/methods.

#### Supported Algorithms/Methods
- Sha256

#### Usage

*Params*
```
method
password
```

*Core Usage*
`("ul_encryption") callExtension "<method>:<password>"`

*Example..*
`("ul_encryption") callExtension "sHa256:myPassword123`

