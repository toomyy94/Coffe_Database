


--sp
 -- stored procedures para adicionar funcionarios, clientes, fornecedores, ... --
drop procedure cafe.SearchFunc

create procedure cafe.SearchFunc(@filter varchar(20))
as
begin
	select *from cafe.Funcionario 
	where nomeFunc like +@filter+'%'
end

exec cafe.SearchFunc 'G'
 


drop proc returnFunc

go
alter proc returnFunc

	@nome varchar(20) output

as
	
		select distinct f.nomeFunc, f.CCFunc, f.moradaFunc, f.telefoneFunc, f.salario, f.turnoFunc
		from cafe.funcionario f
		where f.nomeFunc = @nome

go
exec returnFunc 'Tomas'

go
create proc returnCliente

	@nome varchar(20) output

as
	
		select c.nomeCli, c.CC_Cliente, c.moradaCli, c.telefoneCli
		from cafe.Cliente c
		where c.nomeCli = @nome

go

go
create proc returnCompras

	@num int output

as
		select c.nºcompra, c.forma_pagamento, c.data_compra , c.nome_prod
		from cafe.Compras c
		where c.nºcompra = @num

go

exec returnCompras '1'
exec returnCompras '2'

go
create proc returnEncomenda

	@num int output

as
		select c.nºencomenda, c.data_realizacao, c.quantidade
		from cafe.Encomenda c
		where c.nºencomenda = @num

go

exec returnEncomenda '1'

go
create proc returnFornecedores

	@nome varchar(20) output

as
		select c.nomeForn, c.codigo_interno, c.moradaForn, c.telefoneForn, c.forma_pag
		from cafe.Fornecedor c
		where c.nomeForn = @nome

go

go
create proc returnProduto

	@nome varchar(20) output

as
		select c.nomeProd, c.prodID, c.familia, c.preco
		from cafe.Produto c
		where c.nomeProd = @nome

go

exec returnProduto 'café'
exec returnProduto 'chá'

go
create proc returnReclamacao

	@num varchar(20) output

as
		select c.nºreclamacao, c.motivo, c.reclam_nifCli
		from cafe.Reclamacao c
		where c.nºreclamacao = @num

go
exec returnReclamacao '1'

-- stored procedure para eliminar funcionario --
drop proc cafe.sp_DeleteFunc
create proc cafe.sp_DeleteFunc_by_PK

	@numFuncionario int
as
	delete from cafe.Funcionario 
	where numFunc = @numFuncionario 

go
select *from cafe.Funcionario
exec cafe.sp_DeleteFunc @numFuncionario

-- stored procedure para eliminar fornecedor
create proc cafe.sp_DeleteForn_by_PK

	@codigoFornecedor int
as
	delete from cafe.Fornecedor 
	where codigo_interno = @codigoFornecedor
go
exec cafe.sp_DeleteForn_by_PK 1234
select *from cafe.Fornecedor

-- stored procedure para eliminar cliente
create proc cafe.sp_DeleteCliente_by_CC

	@ccCliente int
as
	delete from cafe.Cliente 
	where CC_Cliente = @ccCliente
go
exec cafe.sp_DeleteCliente_by_CC 12345023
select *from cafe.Cliente

-- stored procedure para eliminar Encomenda
create proc cafe.sp_DeleteEncomenda_by_PK

	@numEncomenda int
as
	delete from cafe.Encomenda 
	where nºencomenda = @numEncomenda
go
exec cafe.sp_DeleteEncomenda_by_PK 1
select *from cafe.Encomenda

-- stored procedure para eliminar Horário
create proc cafe.sp_DeleteHorario_by_PK

	@turnoFunc varchar(20)
as
	delete from cafe.horario 
	where turno = @turnoFunc
go
exec cafe.sp_DeleteHorario_by_PK 
select *from cafe.Horario

-- stored procedure para eliminar Reclamacao
create proc cafe.sp_DeleteReclamacao_by_PK

	@numReclam int
as
	delete from cafe.Reclamacao 
	where nºreclamacao = @numReclam
go
exec cafe.sp_DeleteReclamacao_by_PK 1
select *from cafe.Reclamacao

-- stored procedure para eliminar Compras
create proc cafe.sp_DeleteCompras_by_PK

	@numCompra int
as
	delete from cafe.Compras 
	where nºcompra = @numCompra
go
exec cafe.sp_DeleteCompras_by_PK 1
select *from cafe.Compras


-- stored procedure para eliminar Reclamacao
create proc cafe.sp_DeleteProduto_by_PK

	@IDProd int
as
	delete from cafe.Produto 
	where prodID = @IDProd
go
exec cafe.sp_DeleteProduto_by_PK 19
select *from cafe.Produto

---------------------------------------------------------------------
-- stored procedures for update --
drop proc cafe.sp_UpdateFunc

-- update funcionario
create proc cafe.sp_UpdateFunc
	@NomeFunc varchar(20),
	@CCFunc int,
	@NumFunc int,
	@MoradaFunc varchar(35),
	@TelefoneFunc int,
	@SalarioFunc decimal(10,2),
	@SuperFunc int, 
	@TurnoFunc varchar(20)
 
AS
	BEGIN
		UPDATE cafe.Funcionario
		SET nomeFunc =  @NomeFunc, CCFunc = @CCFunc, numFunc = @NumFunc, moradaFunc = @MoradaFunc, 
				telefoneFunc = @TelefoneFunc, salario = @SalarioFunc, SuperFunc = @SuperFunc, turnoFunc = @TurnoFunc 
		WHERE CCFunc = @CCFunc
	END
go	

select *from cafe.Funcionario
-- -- update cliente--
create proc cafe.sp_UpdateCliente
	@NomeCli varchar(20),
	@CCCliente int,
	@NIF int,
	@MoradaCli varchar(35),
	@TelefoneCli int
 
AS
	BEGIN
		UPDATE cafe.Cliente
		SET nomeCli =  @NomeCli, CC_Cliente = @CCCliente, NIF = @NIF, moradaCli = @MoradaCli, 
				telefoneCli = @TelefoneCli
		WHERE CC_Cliente = @CCCliente
	END
go

-- update fornecedor --
create proc cafe.sp_UpdateFornecedor
	@NomeForn varchar(20),
	@CCForn int,
	@codigo varchar(20),
	@MoradaForn varchar(20),
	@TelefoneForn int,
	@Fax int,
	@pagamento varchar(20)
 
AS
	BEGIN
		UPDATE cafe.Fornecedor
		SET nomeForn =  @NomeForn, CC_Forn = @CCForn, codigo_interno = @codigo, moradaForn = @MoradaForn, 
				telefoneForn = @TelefoneForn, fax = @Fax, forma_pag = @pagamento
		WHERE CC_Forn = @CCForn
	END
go

-- update encomendas --
create proc cafe.sp_UpdateEncomendas
	@numero int,
	@data date,
	@quantity int,
	@codFornecedor varchar(20),
	@FuncResponsavel int
 
AS
	BEGIN
		UPDATE cafe.Encomenda
		SET nºencomenda =  @numero, data_realizacao = @data, quantidade = @quantity, Enc_cod_int = @codFornecedor, enc_numFunc = @FuncResponsavel 
		WHERE nºencomenda = @numero 
	END
go

-- update compras --
create proc cafe.sp_UpdateCompras
	@numero int,
	@pagamento varchar(20),
	@data date,
	@nomeProdutos varchar(35),
	@FuncAtendeu int,
	@NIFCliente int
 
AS
	BEGIN
		UPDATE cafe.Compras
		SET nºcompra = @numero, forma_pagamento = @pagamento, data_compra = @data, nome_prod = @nomeProdutos, 
			compras_numFunc = @FuncAtendeu, compras_nifCli = @NIFCliente  
		WHERE nºcompra = @numero  
	END
go

-- update produtos --
create proc cafe.sp_UpdateProdutos
	@ID int,
	@nomeproduto varchar(20),
	@tipo varchar(20),
	@price decimal(10,2),
	@FuncServiu int,
	@EncomendaProd int
 
AS
	BEGIN
		UPDATE cafe.Produto
		SET prodID = @ID, nomeProd = @nomeproduto, familia = @tipo, preco = @price, 
				prod_numFunc = @FuncServiu, prod_nºencomenda = @EncomendaProd 
		WHERE prodID = @ID 
	END
go

-- update horario ---
create proc cafe.sp_UpdateHorario
	@horario varchar(20),
	@horas int

AS
	BEGIN
		UPDATE cafe.horario
		SET turno = @horario, numeroHoras = @horas
		WHERE numeroHoras = @horas 
	END
go

-- update reclamacao --
create proc cafe.sp_UpdateReclamacao
	@numeroRecla int,
	@motivoRecla varchar(15),
	@NIFRecla int

AS
	BEGIN
		UPDATE cafe.Reclamacao
		SET nºreclamacao = @numeroRecla, motivo = @motivoRecla, reclam_nifCli = @NIFRecla 
		WHERE nºreclamacao = @numeroRecla 
	END
go



-- stored procedures para inserção funcionários--
create proc cafe.sp_InsertFunc
	@NomeFunc varchar(20),
	@CCFunc int,
	@NumFunc int,
	@MoradaFunc varchar(35),
	@TelefoneFunc int,
	@SalarioFunc decimal(10,2),
	@SuperFunc int, 
	@TurnoFunc varchar(20)
 
as
 
	begin 
		insert into cafe.Funcionario(nomeFunc, CCFunc, numFunc, moradaFunc, telefoneFunc, salario, SuperFunc, turnoFunc) 
		values(@NomeFunc, @CCFunc, @NumFunc, @MoradaFunc, @TelefoneFunc, @SalarioFunc, @SuperFunc, @TurnoFunc)
	end 

go


-- stored procedures para inserção clientes--
create proc cafe.sp_InsertCliente
	@NomeCli varchar(20),
	@CCCliente int,
	@NIF int,
	@MoradaCli varchar(35),
	@TelefoneCli int
 
as
 
	begin 
		insert into cafe.Cliente(nomeCli, CC_Cliente, NIF, moradaCli, telefoneCli) 
		values(@NomeCli, @CCCliente, @NIF, @MoradaCli, @TelefoneCli)
	end 

go

select *from cafe.Compras
-- stored procedures para inserção de fornecedores --
create proc cafe.sp_InsertForn
	@NomeForn varchar(20),
	@CCForn int,
	@codigo varchar(20),
	@MoradaForn varchar(20),
	@TelefoneForn int,
	@Fax int,
	@pagamento varchar(20)
 
as
 
	begin 
		insert into cafe.Fornecedor(nomeForn, CC_Forn, codigo_interno, moradaForn, 
					telefoneForn, fax, forma_pag) 
		values(@NomeForn, @CCForn, @codigo, @MoradaForn, @TelefoneForn, @Fax, @pagamento)
	end 

go

-- sp inserção de compras
create proc cafe.sp_InsertCompras
	@numero int,
	@pagamento varchar(20),
	@data date,
	@nomeProdutos varchar(35),
	@FuncAtendeu int,
	@NIFCliente int
 
as
 
	begin 
		insert into cafe.Compras(nºcompra, forma_pagamento, data_compra, nome_prod, 
					compras_numFunc, compras_nifCli) 
		values(@numero, @pagamento, @data, @nomeProdutos, @FuncAtendeu, @NIFCliente)
	end 

go

-- sp inserção de encomendas
create proc cafe.sp_InsertEncomendas
	@numero int,
	@data date,
	@quantity int,
	@codFornecedor varchar(20),
	@FuncResponsavel int
 
as
 
	begin 
		insert into cafe.Encomenda(nºencomenda, data_realizacao, quantidade, Enc_cod_int, enc_numFunc) 
		values(@numero, @data, @quantity, @codFornecedor, @Funcresponsavel)
	end 

go

-- insercao de produtos
create proc cafe.sp_InsertProdutos
	@ID int,
	@nomeproduto varchar(20),
	@tipo varchar(20),
	@price decimal(10,2),
	@FuncServiu int,
	@EncomendaProd int
 
as
 
	begin 
		insert into cafe.Produto(prodID, nomeProd, familia, preco, prod_numFunc, prod_nºencomenda) 
		values(@ID, @nomeproduto, @tipo, @price, @FuncServiu, @EncomendaProd)
	end 

go

-- sp inserção de horário --
create proc cafe.sp_InsertHorario
	@horario varchar(20),
	@horas int
 
as
 
	begin 
		insert into cafe.horario(turno, numeroHoras) 
		values(@horario, @horas)
	end 

go


-- sp inserção de reclamação --
create proc cafe.sp_InsertReclamacao
	@numeroRecla int,
	@motivoRecla varchar(15),
	@NIFRecla int
 
as
 
	begin 
		insert into cafe.Reclamacao(nºreclamacao, motivo, reclam_nifCli) 
		values(@numeroRecla, @motivoRecla, @NIFRecla)
	end 

go


-- triggers-----
-- mensagem de inserção de um funcionário
create trigger trg_insertValue on cafe.Funcionario
for insert

As
	if(select count(*) from inserted) = 1
		print 'Funcionário inserido com sucesso'

go

-- trigger para impedir que funcionários sem supervisor sejam apagados
disable trigger trg_deleteFunc on cafe.Funcionario
create trigger trg_deleteFunc on cafe.Funcionario
for delete

As
	if(select count(*) from deleted) = 1
	begin
		RAISERROR('Funcionários sem supervisor não podem ser removidos!', 16, 1);
		rollback tran	
	End

	delete from cafe.Funcionario
	where SuperFunc = null
go	





--insert into cafe.Funcionario
--values('Luis Semedo', 12340001, 20, 'Rua das taças', 912222212, 600, 1, 'noite')



-- udf ---
drop function cafe.PesquisaFuncionario
create function cafe.PesquisaFuncionario(@nomefuncionario varchar(20)) returns table
as
	return(select nomeFunc, CCFunc 
			from cafe.Funcionario
			where nomeFunc LIKE +@nomefuncionario+'%')

go

select *from cafe.PesquisaFuncionario('An')

drop function cafe.totalOrcamentoProduto

-- função para retornar o valor total ganho com determinado produto--
create function cafe.totalOrcamentoProduto(@produto varchar(20) = null) 
		returns @orcamento table(nomeProduto varchar(20) null, Valor_Total money null, Total_vendido int null)
as
	begin
		insert @orcamento select nomeProd, sum(preco) as total, count(prodID)
						from cafe.Produto Join cafe.Contidos on prodID = prodID_cont
						where nomeProd = @produto
						group by nomeProd;
		return;
	end;
go

select *from cafe.totalOrcamentoProduto('café')

-- função para retornar o valor total ganho com todos os produtos--
drop function cafe.totalOrcamentoTodosProdutos
create function cafe.totalOrcamentoTodosProdutos()
		returns @orcamentoTodos table(nomeProduto varchar(20) null, Valor_Total money null, Total_vendido int null)
as
	begin
		insert @orcamentoTodos select nomeProd, sum(preco) as total, count(prodID)
						from cafe.Produto Join cafe.Contidos on prodID = prodID_cont
						group by nomeProd;
		return;
	end;
go

select *from cafe.totalOrcamentoTodosProdutos()


-- UDF para retornar tabela com total de compras efectuadas, produtos comprados e dinheiro gasto por cada cliente---
create function cafe.compraTotalCliente(@clienteNIF int = null) returns @ClienteInfo 
	table(Total_Compras_Efectuadas int null, Produtos_Comprados varchar(75) null, Total_Gasto money null)

as
	begin
		insert @ClienteInfo select count(nºcompra), nome_prod, sum(preco)
			from (((cafe.Cliente Join cafe.Compras on NIF=compras_nifCli) Join cafe.Contidos on nºcompra = nºcompra_contid) Join cafe.Produto on prodID_cont = prodID)
			where NIF = @clienteNIF
			group by nome_prod
		return;
	end;
go


-- UDF para retornar tabela com total de compras efectuadas, produtos comprados e dinheiro gasto por todos os clientes---
drop function cafe.compraTotalClienteTodos
create function cafe.compraTotalClienteTodos() returns @ClienteInfoToda 
	table(Total_Compras_Efectuadas int null, Produtos_Comprados varchar(75) null, Total_Gasto money null, NIF int null)

as
	begin
		insert @ClienteInfoToda select count(nºcompra), nome_prod, sum(preco), NIF
			from (((cafe.Cliente Join cafe.Compras on NIF=compras_nifCli) Join cafe.Contidos on nºcompra = nºcompra_contid) Join cafe.Produto on prodID_cont = prodID)
			group by nome_prod, NIF
		return;
	end;
go

select *from cafe.compraTotalClienteTodos() 
 								 
	












	
		 
