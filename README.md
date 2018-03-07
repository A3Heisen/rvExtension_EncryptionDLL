# rvExtension_EncryptionDLL

#### *DO NOT RUN WITH BATTLEYE ENABLED ON LOCAL CLIENTS!*

A extension for Real Virtual Reality Engine 4 for Armed Assault 3 (Arma 3 ) to allow users to encrypt their desired string with optional
encryption algorithms/methods.

#### Supported Algorithms/Methods
- Sha256
- MD5

#### Planned Algorithms/Methods
- RSA
- AES 128
- AES 192
- AES 256
- Sha512

#### Usage

*Params*
```
method (forces toLower so not case sensitive)
password
```

*Core Usage*
`("ul_encryption") callExtension "<method>:<password>"`

*Example..*
`("ul_encryption") callExtension "sHa256:myPassword123`

