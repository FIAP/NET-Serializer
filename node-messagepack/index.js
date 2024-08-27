const express = require('express');
const msgpack = require('msgpack-lite');

const app = express();
const port = 3000;

app.use(express.json());

app.get('/', (req, res) => {
  const data = {
    nome: "Thiago S Adriano",
    idade: 38,
    cidade: "São Paulo"
  };

  const encodedData = msgpack.encode(data);

  res.setHeader('Content-Type', 'application/msgpack');
  res.setHeader('Content-Disposition', 'inline; filename=data.msgpack');

  res.send(encodedData);
});

app.listen(port, () => {
  console.log(`Servidor rodando na porta ${port}`);
});