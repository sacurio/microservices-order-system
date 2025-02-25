# Microservices Order System

An project example for practicing Microservices with .NET

This project has the intention to be part of an auto learning process.

The idea behind, it try to simulate an order system for an e-commerce store.

## Services Description

# User Service 👤

- User registration and login
- Profile management
- Authentication with JWT and OAuth2

# Product Service 📦

- Product listing and search
- Stock and availability management

# Order Service 📋

- Order creation, updating, and tracking
- Order status management (pending, shipped, delivered)

# Payment Service 💳

- Payment processing with credit card or PayPal
- Payment confirmation and validation

## Technical Requirements

# ✅ Architecture

- Microservices in .NET 8 (Ubuntu)

# ✅ Communication

- REST/gRPC + Event-Driven with RabbitMQ

# ✅ Database

- PostgreSQL

# ✅ Authentication

- IdentityServer with JWT

# ✅ Containerization

- Docker + Kubernetes

# ✅ Monitoring

- Prometheus + Grafana

# 🏗️ Architecture Design

## 📊 Patterns to Implement

- **API Gateway** (Ocelot or YARP)
- **Service Discovery** (Consul or Kubernetes)
- **CQRS & Event Sourcing** (Orders & Payments)
- **Circuit Breaker** (Resilience with Polly)
- **Saga Pattern** (Distributed transaction management)

## 📍 General Architecture Diagram

_(Coming soon with more details)_
