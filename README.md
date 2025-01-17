# vdi

## Endpoint

```http
  POST /Program/splitChar
```

- **Request**

```json
{
  "input": "123*123"
}
```

- **Response**

```json
{
  "output": "321*321"
}
```

```http
  POST /Program/anagramCheck
```

- **Request**

```json
{
  "firstWords": ["keys", "blood", "aasd"],
  "secondWords": ["eyks", "oodlb", "asaaaa"]
}
```

- **Response**

```json
[1, 1, 0]
```

```http
  POST /Program/discountCalculate
```

- **Request**

```json
{
  "tipeCustomer": "platinum",
  "pointReward": 200,
  "totalBelanja": 500
}
```

- **Response**

```json
{
  "tipeCustomer": "platinum",
  "pointReward": 200,
  "totalBelanja": 500,
  "discount": 285,
  "totalBayar": 215
}
```
