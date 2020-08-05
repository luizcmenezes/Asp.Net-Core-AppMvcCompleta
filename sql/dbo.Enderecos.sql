CREATE TABLE [dbo].[Enderecos] (
    [Id]           UNIQUEIDENTIFIER NOT NULL,
    [FornecedorId] UNIQUEIDENTIFIER NOT NULL,
    [Logradouro]   VARCHAR (200)    NOT NULL,
    [Numero]       VARCHAR (50)     NOT NULL,
    [Complemento]  VARCHAR (250)    NULL,
    [Cep]          VARCHAR (8)      NOT NULL,
    [Bairro]       VARCHAR (100)    NOT NULL,
    [Cidade]       VARCHAR (100)    NOT NULL,
    [Estado]       VARCHAR (50)     NOT NULL,
    CONSTRAINT [PK_Enderecos] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Enderecos_Fornecedores_FornecedorId] FOREIGN KEY ([FornecedorId]) REFERENCES [dbo].[Fornecedores] ([Id])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Enderecos_FornecedorId]
    ON [dbo].[Enderecos]([FornecedorId] ASC);

