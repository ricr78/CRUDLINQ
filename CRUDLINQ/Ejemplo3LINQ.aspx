<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejemplo3LINQ.aspx.cs" Inherits="CRUDLINQ.Ejemplo3LINQ" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
</head>
<body>
    <div class="mx-auto" style="width: 250px">
    <asp:Label runat="server" CssClass="h2" ID="lblTitulo"></asp:Label>
</div>
    <form id="form1" runat="server">
       <div>
     <div class="mb-3">
         <label class="form-label">Nombre</label>
         <asp:TextBox runat="server" CssClass="form-control" ID="txtNombre"></asp:TextBox>
     </div>
     <div class="mb-3">
         <label class="form-label">Apellido</label>
         <asp:TextBox runat="server" CssClass="form-control" ID="txtApellido"></asp:TextBox>
     </div>
     <div class="mb-3">
         <label class="form-label">Genero</label>
         <asp:TextBox runat="server" CssClass="form-control" ID="txtGenero"></asp:TextBox>
     </div>
     <div class="mb-3">
         <label class="form-label">Salario</label>
         <asp:TextBox runat="server"  CssClass="form-control" ID="txtSalario"></asp:TextBox>
     </div>
     <div class="mb-3">
         <label class="form-label">IdDept</label>
         <asp:DropDownList ID="DDLIdDept" CssClass="form-control" runat="server">
             <asp:ListItem>1</asp:ListItem>
             <asp:ListItem>2</asp:ListItem>
             <asp:ListItem>3</asp:ListItem>
         </asp:DropDownList>
        
     </div>

     <asp:Button runat="server" CssClass="btn btn-primary" ID="btnCrear" Text="Crear" Visible="false" OnClick="btnCrear_Click" />
     <asp:Button runat="server" CssClass="btn btn-primary" ID="btnActualizar" Text="Actualizar" Visible="false" OnClick="btnActualizar_Click" />
     <asp:Button runat="server" CssClass="btn btn-primary" ID="btnEliminar" Text="Eliminar" Visible="false" OnClick="btnEliminar_Click" />
     <asp:Button runat="server" CssClass="btn btn-primary btn-dark" ID="btnVolver" Text="Regresar" Visible="true" OnClick="btnVolver_Click" />

 </div>

    </form>
     <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>
