

using Modulo10;



// TrabalhandoComStrings();
// TrabalhandoComDatas();
// TrabalhandoComExcecoes();
// TrabalhandoComArquivos();
TrabalhandoComLinq();

static void TrabalhandoComStrings()
{
    var modulo10 = new TrabalhandoComStrings();

    modulo10.AulaReplace();

}

static void TrabalhandoComLinq()
{
    var trabalhandoComLinq = new Modulo14.TrabalhandoComLinq();


//    trabalhandoComLinq.AulaWhere();
//    trabalhandoComLinq.AulaCount();
//    trabalhandoComLinq.AulaOrderBy();
//    trabalhandoComLinq.AulaTake();
   trabalhandoComLinq.AulaFirstEFirstOrDefault();
}


static void TrabalhandoComArquivos()
{
    var trabalhandoComArquivos = new Modulo13.TrabalhandoComArquivos();

   //  trabalhandoComArquivos.AulaCriandoArquivos();
   // trabalhandoComArquivos.AulaLendoArquivo();
   trabalhandoComArquivos.AulaExcluindoArquivo();
}

static void TrabalhandoComDatas()
{
    var trabalhandoComDatas = new Modulo11.TrabalhandoComDatas();

    // trabalhandoComDatas.AulaDateTime();
    trabalhandoComDatas.AulaSubtraindoDatas();

}

static void TrabalhandoComExcecoes()
{
    var trabalhandocomExcecoes = new Modulo12.TraabalhandoComExcecoes();

    // trabalhandoComDatas.AulaDateTime();
    trabalhandocomExcecoes.AulaGerandoException();

}