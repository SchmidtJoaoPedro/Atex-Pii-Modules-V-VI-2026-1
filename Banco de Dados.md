Antes de executar o sistema, crie o banco de dados **bancoPII** no SQL Server e execute os scripts abaixo para criar as tabelas necessárias.

## Criação do Banco

```sql
CREATE DATABASE bancoPII;
GO

USE bancoPII;
GO
```

## Tabela Categoria

Armazena as categorias das cestas básicas.

```sql
CREATE TABLE Categoria (
    codigoCategoria INT IDENTITY(1,1) PRIMARY KEY,
    descricao NVARCHAR(50) NOT NULL
);
```

## Tabela CestasBasicas

Armazena as informações das cestas básicas e sua respectiva categoria.

```sql
CREATE TABLE CestasBasicas (
    codigoCesta INT IDENTITY(1,1) PRIMARY KEY,
    codigoCategoria INT NOT NULL,
    quantidade INT NOT NULL,

    CONSTRAINT FK_CestasBasicas_Categoria
        FOREIGN KEY (codigoCategoria)
        REFERENCES Categoria(codigoCategoria)
);
```

## Tabela Beneficiario

Armazena os dados dos beneficiários.

```sql
CREATE TABLE Beneficiario (
    codigoBeneficiario INT IDENTITY(1,1) PRIMARY KEY,
    nomeBeneficiario NVARCHAR(50) NOT NULL,
    endereco NVARCHAR(100) NOT NULL
);
```

## Tabela Entrega

Armazena o histórico de entregas realizadas aos beneficiários.

```sql
CREATE TABLE Entrega (
    codigoEntrega INT IDENTITY(1,1) PRIMARY KEY,
    codigoCesta INT NOT NULL,
    codigoBeneficiario INT NOT NULL,
    dataEntrega DATE NOT NULL,

    CONSTRAINT FK_Entrega_Cesta
        FOREIGN KEY (codigoCesta)
        REFERENCES CestasBasicas(codigoCesta),

    CONSTRAINT FK_Entrega_Beneficiario
        FOREIGN KEY (codigoBeneficiario)
        REFERENCES Beneficiario(codigoBeneficiario)
);
```

## Relacionamentos

- Categoria (1:N) CestasBasicas
  - Uma categoria pode possuir várias cestas básicas.
  - Cada cesta básica pertence a uma única categoria.

- CestasBasicas (1:N) Entrega
  - Uma cesta básica pode estar associada a várias entregas.

- Beneficiario (1:N) Entrega
  - Um beneficiário pode receber várias entregas.
  - Cada entrega pertence a um único beneficiário.

## Dados de Teste

```sql
INSERT INTO Categoria (descricao)
VALUES
('Alimentos'),
('Higiene'),
('Emergencial');

INSERT INTO CestasBasicas (codigoCategoria, quantidade)
VALUES
(1, 10),
(2, 5),
(3, 8);

INSERT INTO Beneficiario (nomeBeneficiario, endereco)
VALUES
('João Silva', 'Rua das Flores, 123'),
('Maria Oliveira', 'Av. Brasil, 456'),
('Carlos Ferreira', 'Av. São Paulo, 654');

INSERT INTO Entrega (codigoCesta, codigoBeneficiario, dataEntrega)
VALUES
(1, 1, GETDATE()),
(2, 2, GETDATE()),
(3, 3, GETDATE());
```

## Observações

- O banco utilizado é o SQL Server.
- As chaves primárias são geradas automaticamente através de `IDENTITY(1,1)`.
- Os relacionamentos são garantidos por meio de chaves estrangeiras (`FOREIGN KEY`).
- Execute os scripts na ordem apresentada para evitar erros de dependência entre tabelas.
