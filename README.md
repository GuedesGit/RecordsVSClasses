# 🧙‍♂️ Records vs Classes in C# (.NET 8.0)

This demo showcases the **difference between `class` and `record`** in C# using a magical wizard theme 🪄⚡️.

---

## 🔍 What’s Inside?

### 🧱 `WizardClass`
- Mutable
- Reference equality (`Equals` compares memory addresses)
- Must override `ToString`, `Equals`, `GetHashCode` manually

### 🧾 `WizardRecord`
- Immutable by default
- Value equality (`Equals` compares property values)
- Supports `with` expressions (creates a copy with modified values)

---

## 🧪 Run the App

1. Create and navigate to the folder:
   ```bash
   dotnet new console -n RecordsVsClassesDemo
   cd RecordsVsClassesDemo
