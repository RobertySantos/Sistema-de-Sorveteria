create database bdLoja
use bdLoja
go

create table tbCliente(
	codCliente int primary key identity(1,1)
	,nomeCliente varchar (200) not null
	,cpfCliente varchar (16) not null
	,rgCliente varchar (13) not null
	,logradouroCliente varchar (200)not null
	,numCliente varchar(5)
	,compCliente varchar (200)
	,bairroCliente varchar (200) not null
	,cepCliente varchar (200)
	,cidadeCliente varchar (200) not null
	,ufCliente varchar (100) not null

)
create table tbFoneCliente(
	codFoneCliente int primary key identity (1,1)
	,numFoneCliente varchar (14)
	,codCliente int foreign key references tbCliente(codCliente)
)

create table tbFormaPagto(
	codFormaPagto int primary key identity(1,1)
	,descFormaPagto varchar (45)
)
create table tbFornecedor(
	codFornecedor int primary key identity(1,1)
	,nomeFornecedor varchar (45) not null
	,contatoFornecedor varchar (45) not null
	,foneFornecedor varchar (14)
)
create table tbCategoria(
	codCategoria int primary key identity (1,1)
	,descCategoria varchar (45)
)
create table tbProduto(
	codProduto int primary key identity(1,1)
	,nomeProduto varchar (20) not null
	,precoProduto money not null
	,codCategoria int foreign key references tbCategoria(codCategoria)
	,codFornecedor int foreign key references tbFornecedor(codFornecedor)
	,qtdeEstoque int not null
)
create table tbUsuario(
	codUsuario int primary key identity (1,1)
	,nomeUsuario varchar (45) not null
	,loginUsuario varchar (45) not null
	,senhaUsuario varchar (45) not null
)
create table tbVenda(
	codVenda int primary key identity (1,1)
	,dataVenda date not null
	,valorTotalVenda money not null
	,codUsuario int foreign key references tbUsuario(codUsuario)
	,codCliente int foreign key references tbCliente(codCliente)
)
create table tbParcela(
	codParcela int primary key identity(1,1)
	,codVenda int foreign key references tbVenda(codVenda)
	,codFormaPagto int foreign key references tbFormaPagto(codFormaPagto)
)
create table tbItemVenda(
	codItemVenda int primary key identity(1,1)
	,codVenda int foreign key references tbVenda(codVenda)
	,codProduto int foreign key references tbProduto(codProduto)
	,qtdeItemVenda int not null
	,subTotalItemVenda money not null
)

UPDATE tbCliente SET nomeCliente = 'Xuliana',cpfCliente = '0844754',rgCliente = '1511565',logradouroCliente='Rua CT',numCliente='10',compCliente='B',cidadeCliente='SP',cepCliente='08471520',bairroCliente='CT' from tbCliente where codCliente = 1