<%@ page language="java" import="java.util.*" pageEncoding="ISO-8859-1"%>
<%@page import="com.dts.dae.model.Profile"%>
<%@page import="com.dts.uas.dao.RegistrationDAO"%>
<%
String path = request.getContextPath();
String basePath = request.getScheme()+"://"+request.getServerName()+":"+request.getServerPort()+path+"/";
%>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
  <head>
    <base href="<%=basePath%>">
    
    <title>My JSP 'ViewScheduleAction.jsp' starting page</title>
    
	<meta http-equiv="pragma" content="no-cache">
	<meta http-equiv="cache-control" content="no-cache">
	<meta http-equiv="expires" content="0">    
	<meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
	<meta http-equiv="description" content="This is my page">
	<!--
	<link rel="stylesheet" type="text/css" href="styles.css">
	-->

  </head>
  
  <body>
  	<%
			String target = "ViewSchedule.jsp?status=failed";
				try{
				 Profile  rb=new Profile();
				 //String appno = request.getParameter("appno");
		         rb.setHno(appno);
	         rb=new RegistrationDAO().viewExamSchdule(;
		         session.setAttribute("hno",rb.getHno());
		         session.setAttribute("place",rb.getCity());
		         session.setAttribute("date",rb.getRegDate());
		        
		         
		             }catch(Exception e){} 
		        response.sendRedirect("View.jsp");
		%>
	</body>
</html>

