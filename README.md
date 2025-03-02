Supervisório para Bancada de Medição do Efeito Magnetocalórico

Este repositório contém o código de um supervisório para a bancada de medição direta do efeito magnetocalórico.
Instruções de Uso

    Controlador com Arduino:
    Para utilizar o supervisório, é necessário conectar um Arduino com os equipamentos descritos na interface.
    O código principal a ser carregado no Arduino está no arquivo Codigo_Arduino_Com_Rele.ino.

    Leitura de Sensores com Segundo Arduino (opcional):
    Para a leitura dos sensores, pode-se usar um segundo Arduino com o código Codigo_Sensores.ino.
    Para esse código, é necessário instalar a biblioteca MAX31856, que está incluída neste repositório como MAX31856.zip.

Observações:

    Os arquivos Codigo_Sensores.ino e MAX31856.zip devem ser mantidos separados dos demais arquivos do projeto.
