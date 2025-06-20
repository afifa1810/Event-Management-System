![image](https://github.com/user-attachments/assets/d5542d36-d7f4-4838-a284-c92b3f61a13b)# 🎉 Event Management System
#Eventify
This is a web-based Event Management System developed using **ASP.NET (C#)** with a **SQL Server** local database. It allows users to manage event information, see past events and register for new ones.. The project is designed to run on **localhost** and is ideal for academic or learning purposes. It is also connected to local database, on registering for any event, it can be seen in the web in my schedule.

---

## 📌 Features

- Add and see events (Contact us page offering many categories)
- view past events (pictures and details and articles)
- beautiful, aesthetic and pastel UI for every single event details.
- FAQs and privacy policy page.

---

## 💻 Technologies Used

- **Frontend:** HTML, CSS, JavaScript
- **Backend:** ASP.NET Web Forms (C#)
- **Database:** SQL Server (.mdf)

---

## 🚀 How to Run

1. **Clone this repository**  
   ```bash
   git clone https://github.com/afifa1810/Event-Management-System.git
````

2. **Opne in Visual studio**

   * Open the `.sln` file
   * Make sure the database is attached via `.mdf` or setup manually via SQL script (You can watch youtube video for database connection, if not working, link : https://www.youtube.com/watch?v=va2Va-vCHpk )

3. **Update your `Web.config` connection string**
   Replace with your SQL Server name and database name:

   ```xml
   <connectionStrings>
     <add name="YourDBConnectionName" connectionString="Data Source=.;Initial Catalog=YourDB;Integrated Security=True" providerName="System.Data.SqlClient"/>
   </connectionStrings>
   ```

4. **Run the project**
   Press `F5` or click **Start** in Visual Studio to launch on localhost.

---

## 📂 Project Structure (Example)

```
├── App_Data/           # Database files (.mdf)
├── Pages/              # ASP.NET pages (.aspx)
├── Scripts/            # JavaScript files
├── Web.config          # Configuration and connection string
├── EventManagement.sln # Solution file
```

---

## 🧑‍💻 Author

Project by: Afifa Nigam, Hina Saleem and Abeeha fatima
Contact us:
- email: afifanigam2323@gmail.com 

---

## 📸 Screenshots (Optional)

![Home Page](https://github.com/user-attachments/assets/aa6c04e3-9f14-4451-91ce-88b2e25ed9a6)




---

## 📃 License

This project is for educational purposes only.

---
```
