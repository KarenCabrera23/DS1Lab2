﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Registrar Video</title>
</head>
<body>
    <form action="/Video/Create" method="post">
    <fieldset>
    <legend>Datos del Video</legend>

    <label for= "idVideo">ID Video</label>
    <input type= "text" name="idVideo"/>

    <label for= "titulo">Titulo</label>
    <input type= "text" name="titulo"/>

    <label for= "repro">Reproduciones</label>
    <input type= "text" name="repro"/>

    <label for= "url">URL</label>
    <input type= "text" name="url"/>

    <input type="submit" value="Agregar Video"/>

    </fieldset>
    </form>
   
       
    
</body>
</html>
