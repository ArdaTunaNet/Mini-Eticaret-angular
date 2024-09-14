# Mini-Eticaret-angular



Bu proje, **ASP.NET Core 6** ve **Angular** kullanılarak geliştirilmiş bir mini e-ticaret uygulamasıdır. Projede **Onion Architecture** (Soğan Mimarisi) uygulanmıştır, bu da katmanlı bir yapı ve bağımlılıkların yönetimini kolaylaştıran temiz bir mimari sağlar.



## Özellikler

- Ürün listeleme ve detay görüntüleme
- Kullanıcı oturumu açma ve kapama
- Sepete ürün ekleme ve sipariş verme
- Yönetici paneli ile ürün yönetimi
- Basit ödeme entegrasyonu

## Teknolojiler

Bu projede kullanılan ana teknolojiler şunlardır:

- **ASP.NET Core 6:** Backend API geliştirme.
- **Angular:** Frontend kullanıcı arayüzü.
- **Onion Architecture:** Bağımlılıkların yönetimini ve katmanlı mimariyi kolaylaştıran yapı.
- **Entity Framework Core:** Veritabanı işlemleri için ORM.
- **MSSQL:** Veritabanı yönetimi.
- 

## Mimari

Uygulama, **Onion Architecture** prensipleri ile yapılandırılmıştır. Temel katmanlar:

- **Core:** Uygulamanın iş mantığı ve alan modellerini içerir.
- **Application:** İş mantığını uygulayan servisleri ve kuralları içerir.
- **Infrastructure:** Veritabanı ve dış kaynaklarla olan iletişimi sağlar.
- **Presentation:** Kullanıcı arayüzü (Angular) ve API'yi içerir.

Bu mimari sayesinde uygulama, esneklik ve test edilebilirlik sağlar.

**English**
# Mini-Eticaret-Angular

This project is a mini e-ticaret application developed using **ASP.NET Core 6** and **Angular**. The project implements **Onion Architecture**, which provides a layered structure and simplifies dependency management through a clean architecture.

## Features

- Product listing and detail viewing
- User login and logout
- Add products to cart and place orders
- Admin panel for product management
- Simple payment integration

## Technologies

The main technologies used in this project are:

- **ASP.NET Core 6:** Backend API development.
- **Angular:** Frontend user interface.
- **Onion Architecture:** A structure that simplifies dependency management and layered architecture.
- **Entity Framework Core:** ORM for database operations.
- **MSSQL:** Database management.

## Architecture

The application is structured based on **Onion Architecture** principles. The main layers include:

- **Core:** Contains the business logic and domain models of the application.
- **Application:** Implements services and rules that apply the business logic.
- **Infrastructure:** Manages database interactions and external resources.
- **Presentation:** Contains the user interface (Angular) and the API.

This architecture allows the application to be flexible and easily testable.


