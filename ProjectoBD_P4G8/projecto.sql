create schema cafe;

drop table cafe.Funcionario;

alter table cafe.Funcionario add constraint Supervisor foreign key(SuperFunc) references cafe.Funcionario(numFunc)
alter table cafe.Funcionario drop constraint SuperFuncFK; 
alter table cafe.Funcionario drop constraint Supervisor;
alter table cafe.Funcionario alter column moradaFunc varchar(35);
	
create table cafe.Funcionario(
	nomeFunc varchar(20) not null,
	CCFunc int,
	numFunc int,
	moradaFunc varchar(20),
	telefoneFunc int,
	salario decimal(10,2) check(salario > 0),
	SuperFunc int,
	turnoFunc varchar(20),
	
	primary key(numFunc),
	foreign key(turnoFunc) references cafe.horario(turno)
			on delete set null   on update cascade,
);

alter table cafe.Cliente alter column moradaCli varchar(35);
create table cafe.Cliente(
	nomeCli varchar(20) not null,
	CC_Cliente int,
	NIF int,
	moradaCli varchar(20),
	telefoneCli int,
	
	primary key(NIF),
);

create table cafe.Fornecedor(
	nomeForn varchar(20) not null,
	CC_Forn int,
	codigo_interno varchar(20),
	moradaForn varchar(20),
	telefoneForn int,
	fax int,
	forma_pag varchar(20),

	primary key(codigo_interno),
);


create table cafe.horario(
	turno varchar(20),
	numeroHoras int,

	primary key(turno),
);

drop table cafe.Encomenda;
create table cafe.Encomenda(
	nºencomenda int,
	data_realizacao date,
	quantidade int,
	Enc_cod_int varchar(20),
	enc_numFunc int,

	primary key(nºencomenda),
	foreign key(Enc_cod_int) references cafe.Fornecedor(codigo_interno)
				on delete set null  on update cascade,
	
	foreign key(enc_numFunc) references cafe.Funcionario(numFunc)
				on delete set null  on update cascade,
);

create table cafe.Compras(
	nºcompra int,
	forma_pagamento varchar(20),
	data_compra date,
	nome_prod varchar(35),
	compras_numFunc int,
	compras_nifCli int,

	primary key(nºcompra),
	foreign key(compras_numFunc) references cafe.Funcionario(numFunc)
				on delete set null  on update cascade,
	
	foreign key(compras_nifCli) references cafe.Cliente(NIF)
				on delete set null  on update cascade,
);

ALTER TABLE	cafe.Produto ADD familia varchar(20)
alter table cafe.Produto drop column familia



drop table cafe.Produto
create table cafe.Produto(
	prodID int,
	nomeProd varchar(20),
	familia varchar(20),
	preco decimal(10,2) check (preco > 0),
	prod_numFunc int,
	prod_nºencomenda int,

	primary key(prodID),
	foreign key(prod_numFunc) references cafe.Funcionario(numFunc),
				
	foreign key(prod_nºencomenda) references cafe.Encomenda(nºencomenda)
				on delete set null  on update cascade,
);


create table cafe.Reclamacao(
	nºreclamacao int,
	motivo varchar(15),
	reclam_nifCli int,

	primary key(nºreclamacao),
	foreign key(reclam_nifCli) references cafe.Cliente(NIF)
				on delete set null  on update cascade,

);

drop table cafe.Contidos
alter table cafe.Contidos alter column prodID_cont int 
create table cafe.Contidos(
	nºcompra_contid int,
	prodID_cont int,
	unidades int,

	primary key(nºcompra_contid, prodID_cont),
	foreign key(nºcompra_contid) references cafe.Compras(nºcompra),
	
	foreign key(prodID_cont) references cafe.Produto(prodID)
);

drop table cafe.ProdContEnc
create table cafe.ProdContEnc(
	contEnc_prodIDint int,
	contEnc_numEnc int,


	primary key(contEnc_prodIDint, contEnc_numEnc),
	foreign key(contEnc_prodIDint) references cafe.Produto(prodID),
	
	foreign key(contEnc_numEnc) references cafe.Encomenda(nºencomenda)
);




