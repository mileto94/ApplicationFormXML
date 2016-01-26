<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/Applicants">
      <html>
        <style>
          body {
            font-size: 14;
            font-family: "Trebuchet MS", Helvetica, sans-serif;
          }
          .highlighted th {
            width: 150px;
            color: cornflowerblue;
          }
          table, tr, th, td {
            border: 1px solid black;
          }
          .applicant {
            border-bottom: 1px dashed black;
            padding-bottom: 20px;
          }
        </style>
        <body>
          <h1>Applicants</h1>
          <xsl:for-each select="Applicant" xml:space="preserve">
            <div class="applicant">
              <h2>Name: <xsl:value-of select="PersonalInfo/@FirstName"/> <xsl:value-of select="PersonalInfo/@LastName"/></h2>
              <h3>Personal Info</h3>
                <p>Age: <xsl:value-of select="PersonalInfo/@Age"/></p>
                <p>Email: <xsl:value-of select="PersonalInfo/@Email"/></p>
                <p>Country: <xsl:value-of select="PersonalInfo/Address/@Country"/></p>
                <p>State: <xsl:value-of select="PersonalInfo/Address/@State"/></p>
                <p>City: <xsl:value-of select="PersonalInfo/Address/@City"/></p>
                <p>Phone Number: <xsl:value-of select="PersonalInfo/PhoneNumber"/></p>
              <h3>Student Info</h3>
                <p>Faculty Number: <xsl:value-of select="StudentInfo/@FacultyNumber"/></p>
                <p>Course Number: <xsl:value-of select="StudentInfo/@Course"/></p>
                <p>Main course: <xsl:value-of select="StudentInfo/MainCourse"/></p>
              <h3>Optional Courses</h3>
                <table>
                  <tr>
                    <th>Course Name</th>
                    <th>Course Credits</th>
                    <th>Professor</th>
                  </tr>
                  <xsl:for-each select="StudentInfo/OptionalCourses/OptionalCourse">
                    <tr>
                      <td>
                        <xsl:value-of select="@Name"/>
                      </td>
                      <td>
                      <xsl:value-of select="@Credits"/></td>
                      <td><xsl:value-of select="Professor/@FirstName"/> <xsl:value-of select="Professor/@LastName"/>
                      </td>
                    </tr>
                  </xsl:for-each>
                </table>
            </div>
          </xsl:for-each>
        </body>
      </html>
    </xsl:template>
</xsl:stylesheet>
