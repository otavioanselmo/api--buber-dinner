# Buber Dinner API

- [Buble Dinner API](#buber-dinner-api)
    - [Auth](#auth)
        - [Register](#register)
            - [Register Request](#register-request)
            - [Register Response](#register-response)
        - [Login](#login)
            - [Login Request](#login-request)
            - [Login Response](#login-response)

## Auth

### Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
{
    "firstName": "Amichai",
    "lastName": "Mantinband",
    "email": "amichai@mantinband.com",
    "password": "Amiko1232!"
}
```

#### Register Response

```js
200 OK
```

```json
{
    "id": "cb815b60-f27d-4a81-b390-a40745ea3e54",
    "firstName": "Amichai",
    "lastName": "Mantinband",
    "email": "amichai@mantinband.com",
    "token": "44f66902-0247-4984-a61a-98e7dab3245f"
}
````

### Login
```js
POST {{host}}/auth/login
```

#### Login Request

```json
{
    "email": "amichai@mantinband.com",
    "password": "Amiko1232!"
}
```

#### Login Response

```js
200 OK
```

```json
{
    "id": "cb815b60-f27d-4a81-b390-a40745ea3e54",
    "firstName": "Amichai",
    "lastName": "Mantinband",
    "email": "amichai@mantinband.com",
    "token": "44f66902-0247-4984-a61a-98e7dab3245f"
}
````