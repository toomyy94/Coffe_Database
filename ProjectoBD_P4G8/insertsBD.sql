insert cafe.horario
   values('manha',8)

insert cafe.horario
   values('tarde',8)

insert cafe.horario
   values('noite',8)


-- inserts funcionário
delete from cafe.Funcionario

insert into cafe.Funcionario
   values('Dona Alcina', 78965456, 1, 'Rua dos Lirios, Aveiro',
   234193409, 2000, null, 'todo-o-dia');

insert into cafe.Funcionario
   values('António', 53452345, 2, 'Rua Assada, Aveiro',
   234634345, 2500, null, 'manha');

   
insert into cafe.Funcionario
   values('Jaqueline', 56898052, 3, 'Rua da Morte, Aveiro',
   917898764, 500, 1, 'manha');

insert into cafe.Funcionario
   values('Tomas', 12345321, 4, 'Rua da Morte, Aveiro',
   913420123, 800, 1, 'todo-o-dia');

insert into cafe.Funcionario
   values('Gabriel', 14472124, 5, 'Rua do Rameiral, Anadia',
   913557656, 1000, 1, 'tarde');

insert into cafe.Funcionario
   values('Joana', 12342345, 6, 'Avenida da Republica, Coimbra',
   962356789, 1200, 2, 'todo-o-dia');

insert into cafe.Funcionario
   values('Andreia', 16742349, 7, 'Avenida dos Aliados, Porto',
   935636280, 700, 2, 'noite');

insert into cafe.Funcionario
   values('Filipa', 19841305, 8, 'Praça do Municipio, Coimbra',
   917306781, 1200, 2, 'manha');

insert into cafe.Funcionario
   values('João', 13427890, 9, 'Rua Assada, Aveiro',
   912345654, 700, 1, 'tarde');

insert into cafe.Funcionario
   values('Chico', 19800341, 10, 'Alameda Principal, Anadia',
   912379098, 1200, 1, 'todo-o-dia');


-- inserts fornecedores

delete from cafe.Fornecedor
insert into cafe.Fornecedor
   values('José Cola', 23456234, 1231, 'Rua das Águas, Vilar',
   917898982, 123345234, 'dinheiro')

insert into cafe.Fornecedor
   values('Manuel Cereja', 23123234, 1232, 'Rua Baixa, Esgueira',
   913485671, 123412313, 'dinheiro')

insert into cafe.Fornecedor
   values('João Pinheiro', 78789976, 1233, 'Rua da Morte, Aveiro',
   932198982, 123723239, 'multibanco')

insert into cafe.Fornecedor
   values('Mário Pereira', 78657432, 1234, 'Travessa Ana, Anadia',
   932198980, 198723234, 'cheque')

insert into cafe.Fornecedor
   values('Margarida Ribeiro', 12345098, 1235, 'Alameda lore, Cacia',
   922198982, 1231232342, 'dinheiro')

insert into cafe.Fornecedor
   values('Susana Silva', 12345023, 1236, 'Rua Assada, Aveiro',
   962198910, 1551237842, 'cheque')

insert into cafe.Fornecedor
   values('Adriana Santos', 12305092, 1237, 'Alameda lore, Cacia',
   910008981, 1990282342, 'multibanco')

insert cafe.Fornecedor
   values('Miguel Tavares', 19145099, 1238, 'Rua Sesamo, Lisboa',
   912197701, 1238890232, 'dinheiro')

insert cafe.Fornecedor
   values('Liliana Sousa', 12777098, 1239, 'Avenida Sacre, Faro',
   932198911, 1231230000, 'cheque')

insert cafe.Fornecedor
   values('Raúl Semedo', 12349999, 1240, 'Rua Matris, Setúbal',
   968998982, 1531552342, 'dinheiro')

insert cafe.Fornecedor
   values('Sofia Fernandes', 13345098, 1241, 'Avenida Axa, Braga',
   932000182, 1231552311, 'multibanco')



-- inserts Cliente
delete from cafe.Cliente
insert into cafe.Cliente
	values('Fausto', 12352890, 212343168, 'Rua Menezes, Salreu', 919394543);

insert into cafe.Cliente
	values('Gisela', 13456729, 364564810, 'Rua Limiar, Aveiro', 939192987);

insert into cafe.Cliente
	values('Adriana Santos', 12305092, 324512678, 'Alameda lore, Cacia', 910008981);

insert into cafe.Cliente
	values('Susana Silva', 12345023, 123345691, 'Rua Assada, Aveiro', 962198910);

insert into cafe.Cliente
	values('Chico', 19800341, 654782919, 'Alameda Principal, Anadia', 912379098);

insert into cafe.Cliente
	values('Mário Pereira', 78657432, 345631219, 'Travessa Ana, Anadia', 932198980);

insert into cafe.Cliente
	values('Gabriel', 14472124, 768362101, 'Rua do Rameiral, Anadia', 913557656);

insert into cafe.Cliente
	values('Francisca Costa', 38749920, 124547093, 'Rua das Avessas, Estarreja', 912345761);

insert into cafe.Cliente
	values('José Dias', 98292362, 453689181, 'Rua dos Lirios, Aveiro', 967565321);

insert into cafe.Cliente
	values('Anabela Reis', 39845821, 132456545, 'Travessa Gil, Ovar', 932156732);

insert into cafe.Cliente
	values('Arnaldo Freitas', 45373949, 123454321, 'Rua 25 Abril, Esgueira', 912389009);


-- inserts compras
delete from cafe.Compras
insert into cafe.Compras
	values(1, 'dinheiro', '04/04/2015', 'cafe', 2, 132456545)
 
insert into cafe.Compras
	values(2, 'multibanco', '01/01/2015', 'chá', 1, 123454321)

insert into cafe.Compras
	values(3, 'dinheiro', '05/04/2015', 'água',3, 132456545)

insert into cafe.Compras
	values(4, 'dinheiro', '06/04/2015', 'fruta, água', 4, 123454321)


insert into cafe.Compras
	values(5, 'multibanco', '01/04/2015', 'sumo, sandes', 1, 453689181)

insert into cafe.Compras
	values(6, 'dinheiro', '02/04/2015', 'café', 4, 453689181)

insert into cafe.Compras
	values(7, 'dinheiro', '07/04/2015', 'chocolate', 7, 453689181)


insert into cafe.Compras
	values(8, 'multibanco', '09/04/2015', 'pastel, batatas fritas, leite',3, 768362101)


insert into cafe.Compras
	values(9, 'dinheiro', '08/04/2015', 'gelado', 9, 124547093)

insert into cafe.Compras
	values(10, 'multibanco', '03/04/2015', 'sandes, café', 6, 124547093)
	

insert into cafe.Compras
	values(11, 'dinheiro', '02/04/2015', 'batatas fritas', 5, 345631219)
	

insert into cafe.Compras
	values(12, 'multibanco', '11/04/2015', 'sumo,pastel,gelado', 10, 123345691)		 

insert into cafe.Compras
	values(13, 'dinheiro', '05/04/2015', 'sumo', 8, 123345691)


insert into cafe.Compras
	values(14, 'dinheiro', '06/04/2015', 'café', 5, 324512678)

insert into cafe.Compras
	values(15, 'multibanco', '07/04/2015', 'café, sandes, chocolate', 8, 324512678)

insert into cafe.Compras
	values(16, 'dinheiro', '08/04/2015', 'água', 10, 324512678)

insert into cafe.Compras
	values(17, 'dinheiro', '06/04/2015', 'pastel', 7, 324512678)


insert into cafe.Compras
	values(18, 'dinheiro', '10/04/2015', 'sumo, croissant', 9, 364564810)

insert into cafe.Compras
	values(19, 'multibanco', '11/04/2015', 'sandes, café', 6, 212343168)

insert into cafe.Compras
	values(20, 'dinheiro', '12/04/2015', 'croissant', 1, 212343168)


select *from cafe.Compras

--inserts encomenda
delete from cafe.Encomenda
insert into cafe.Encomenda
	values(1, '03/04/2015',3, 1231, 3)

insert into cafe.Encomenda
	values(2, '12/04/2015',6, 1232, 5)

insert into cafe.Encomenda
	values(3, '11/04/2015',9, 1232, 7)

insert into cafe.Encomenda
	values(4, '08/04/2015',12, 1236, 1)

insert into cafe.Encomenda
	values(5, '03/04/2015',5, 1235, 2)

insert into cafe.Encomenda
	values(6, '01/04/2015',2, 1239, 2)

insert into cafe.Encomenda
	values(7, '06/04/2015',4, 1240, 4)

insert into cafe.Encomenda
	values(8, '05/04/2015',7, 1241, 4)

insert into cafe.Encomenda
	values(9, '04/04/2015',7, 1233, 5)

insert into cafe.Encomenda
	values(10, '02/04/2015',8, 1238, 10)

insert into cafe.Encomenda
	values(11, '04/04/2015',5, 1237, 9)

insert into cafe.Encomenda
	values(12, '04/15/2015',2, 1235, 9)



-- inserts reclamação 

insert cafe.Reclamacao
	values(1, 'cafe frio',123312394)


insert cafe.Reclamacao
	values(2, 'esquecimento',552346234)


insert into cafe.Reclamacao
	values(3, 'leite frio',768362101)


insert into cafe.Reclamacao
	values(4, 'sumo estragado',123345691)

insert into cafe.Reclamacao
	values(5, 'esquecimento',324512678)


select *from cafe.Compras
-- inserts produtos

delete from cafe.Produto
insert into cafe.Produto
	values(101, 'chá', 'bebida', 0.80, 3, 1)

insert into cafe.Produto
	values(102, 'gelado', 'comida', 1.20, 5, 2)

insert into cafe.Produto
	values(103, 'chocolate', 'comida', 0.75, 7, 3)

insert into cafe.Produto
	values(104, 'leite', 'bebida', 0.75, 6, 2)

insert into cafe.Produto
	values(105, 'batatas fritas', 'comida', 0.85, 2, 5)

insert into cafe.Produto
	values(106, 'croissant', 'comida', 0.90, 9, 12)

insert into cafe.Produto
	values(107, 'água', 'bebida', 0.65, 4, 7)

insert into cafe.Produto
	values(108, 'café', 'comida', 0.50, 4, 8) -- compra nº14

insert into cafe.Produto
	values(109, 'sumo', 'bebida', 0.50, 5, 9) 

insert into cafe.Produto
	values(110, 'pastel', 'comida', 0.85, 10, 10)

insert into cafe.Produto
	values(111, 'sandes', 'comida', 0.80, 9, 11)

insert into cafe.Produto
	values(112, 'fruta', 'comida', 0.55, 9, 12)	 



-- inserts contidos
delete from cafe.Contidos
	
insert into cafe.Contidos
	values(1, 108, 1) -- café

insert into cafe.Contidos
	values(2, 101, 2)

insert into cafe.Contidos
	values(3, 107, 3)

insert into cafe.Contidos
	values(4, 112, 2)

insert into cafe.Contidos
	values(4, 107, 1)

insert into cafe.Contidos
	values(5, 109, 2)
	
insert into cafe.Contidos
	values(5, 111, 3)
	
insert into cafe.Contidos
	values(6, 108, 1)

insert into cafe.Contidos
	values(7, 103, 2)

insert into cafe.Contidos
	values(8, 110, 2)

insert into cafe.Contidos
	values(8, 105, 4)

insert into cafe.Contidos
	values(8, 104, 1)
	
insert into cafe.Contidos
	values(9, 102, 2)
	
insert into cafe.Contidos
	values(10, 111, 1)
	
insert into cafe.Contidos
	values(10, 108, 1)
	
insert into cafe.Contidos
	values(11, 105, 2)
	
insert into cafe.Contidos
	values(12, 109, 2)
	
insert into cafe.Contidos
	values(12, 110, 3)
	
insert into cafe.Contidos
	values(12, 102, 1)
	
insert into cafe.Contidos
	values(13, 109, 1)
	
insert into cafe.Contidos
	values(14, 108, 1)
	
insert into cafe.Contidos
	values(15, 108, 1)
	
insert into cafe.Contidos
	values(15, 111, 3)
	
insert into cafe.Contidos
	values(15, 103, 2)
	
insert into cafe.Contidos
	values(16, 107, 2)

insert into cafe.Contidos
	values(17, 110, 1)
	
insert into cafe.Contidos
	values(18, 109, 1)
	
insert into cafe.Contidos
	values(18, 106, 2)
	
insert into cafe.Contidos
	values(19, 111, 1)
	
insert into cafe.Contidos
	values(19, 108, 1)
	
insert into cafe.Contidos
	values(20, 106, 3)



select *from cafe.Contidos
select *from cafe.Funcionario
