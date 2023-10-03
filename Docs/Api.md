# Buber Dinner API

- [Biber Dinner API](#buber-dinner-api)
    - [Auth](#aith)
        - [Register](#register)
            - [Register Request](#register-request)
            - [Register response](#register-response)
        - [Login](#login)
            - [Login Request](#login-request)
            - [Login response](#login-response)

## Auth

### Register

```js
POST {{host}}/auth/register
```

### Register request

```json
{
    "firstName": "Ayoub",
    "lastName": "chaib",
    "email": "ayoub.chaib.dev@gmail.com",
    "password": "Ayoub123"
}
```

### Register Response

```js
200 ok
```

```json
{   
    "id": "FAE04EC0-301F-11D3-BF4B-00C04F79EFBC",
    "firstName": "Ayoub",
    "lastName": "chaib",
    "email": "ayoub.chaib.dev@gmail.com",
    "token": "ejhf..efdrghy"
}
```


### Login

```js
POST {{host}}/auth/login
```

### Login request

```json
{
    "email": "ayoub.chaib.dev@gmail.com",
    "password": "Ayoub123"
}
```

### Login Response

```js
200 ok
```

```json
{   
    "id": "FAE04EC0-301F-11D3-BF4B-00C04F79EFBC",
    "firstName": "Ayoub",
    "lastName": "chaib",
    "email": "ayoub.chaib.dev@gmail.com",
    "token": "ejhf..efdrghy"
}
```