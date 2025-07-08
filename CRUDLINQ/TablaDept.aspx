<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TablaDept.aspx.cs" Inherits="CRUDLINQ.TablaDept" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">

</head>
<body>
    <nav class="navbar navbar-expand-lg bg-body-tertiary">
    <div class="container-fluid">
        <a class="navbar-brand" href="#">Empleados</a>
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarText" aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarText">
            <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                <li class="nav-item">
                    <a class="nav-link active" aria-current="page" href="default.aspx">Tabla Empleados</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link active" aria-current="page" href="TablaDept.aspx">Tabla Departamentos</a>
                </li>
            </ul>
            <span class="navbar-text">Datos
            </span>
        </div>
    </div>
</nav>
    <form id="form1" runat="server">
             <br />
 <div class="mx-auto" style="width:300px">
     <h2>Departamentos</h2>
 </div>

 <br />
 <div class="container">
     <div class="row">
        
     </div>
 </div>
 <br />
    <div class="container row">
    <div class="table small">
        <asp:GridView runat="server" ID="gvDepart" Class="table table-borderless table-hover"/>
            <Columns>
                 <asp:TemplateField HeaderText="opciones del administrador">
     <ItemTemplate>
         <asp:Button runat="server" Text="Mostrar" CssClass="btn form-control-sm btn-dark" ID="btnMostrar" OnClick="btnMostrar_Click"/>
         

     </ItemTemplate>
 </asp:TemplateField>
            </Columns>
        
    </div>
</div>
    </form>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

</body>
</html>
