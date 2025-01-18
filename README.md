# NGO Management System

## Project Overview
NGO Management System is a web application built with ASP.NET to assist NGOs in automating and tracking their operations. This system focuses on reducing food wastage by collecting surplus food from restaurants and distributing it to underprivileged individuals and children.

## Key Features
- **Restaurant Dashboard**: Restaurants can create food collection requests and specify preservation times.
- **Employee Management**: Assign employees to collect and distribute food efficiently.
- **Request Tracking**: Monitor all collection requests and their statuses.
- **Food Distribution Workflow**: Simplifies food collection and distribution processes.

## System Workflow
1. **Request Creation**: Restaurants create a collection request, specifying the maximum time they can preserve food.
2. **Request Assignment**: The NGO accepts the request and assigns an employee to collect the food.
3. **Food Collection**: Assigned employees collect the food from the restaurant.
4. **Distribution**: The collected food is distributed, and the request is marked as completed.

## Technologies Used
- **Frontend**: ASP.NET MVC
- **Backend**: C#
- **Database**: SQL Server
- **Tools**:
  - Automapper for object mapping.
  - DTOs (Data Transfer Objects) for validation.

## Installation and Usage
Follow these steps to install and run the NGO Management System:

1. Clone the repository:
   ```bash
   git clone https://github.com/Asgorreaj/NGO_ASP.NET.git
   ```
2. Open the project in **Visual Studio**.
3. Restore the NuGet packages:
   - In Visual Studio, go to `Tools` > `NuGet Package Manager` > `Manage NuGet Packages for Solution`.
   - Restore all required dependencies.
4. Configure the database connection string in the `appsettings.json` file to point to your SQL Server instance.
5. Set up the database:
   - Open SQL Server Management Studio (SSMS).
   - Run the `ZERO_SQLQuery_Script.sql` file provided in the repository to create the database and required tables.
6. Build and run the project:
   - Press `Ctrl+F5` in Visual Studio to start the application.

## Contribution
We welcome contributions to enhance the NGO Management System. To contribute:
1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Commit your changes and push them to your forked repository.
4. Submit a pull request with detailed explanations of your changes.

## Future Scope
Enhancements that can be added in the future:
- Mobile app integration for employees and restaurants.
- Real-time notifications for users.
- Analytics dashboard for tracking food distribution impact.

## License
This project is licensed under the [MIT License](LICENSE).

## Contact
If you have any questions or need assistance, feel free to contact:
- **Name**: MD Asgor Hossain Reaj
- **GitHub**: [Asgorreaj](https://github.com/Asgorreaj)

---

Thank you for supporting this initiative. Together, we can create a better future by reducing food wastage and helping those in need.
