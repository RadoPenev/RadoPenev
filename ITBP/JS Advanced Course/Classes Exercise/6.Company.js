class Company {
    constructor() {
        this.departments = {};
    }

    addEmployee(name, salary, position, department) {

        if (!this.departments[department]) {
            this.departments[department] = [];
        }

        this.departments[department].push({ name, salary, position });
        return `New employee is hired. Name: ${name}. Position: ${position}`;
    }

    bestDepartment() {
        let bestDepartmentName = 0;
        let maxAverageSalary = 0;

        for (const department in this.departments) {
            const totalSalary = this.departments[department].reduce((acc, emp) => acc + emp.salary, 0);
            const averageSalary = totalSalary / this.departments[department].length;

            if (averageSalary > maxAverageSalary) {
                maxAverageSalary = averageSalary;
                bestDepartmentName = department;
            }
        }

        const sortedEmployees = this.departments[bestDepartmentName].sort((a, b) => {
            if (b.salary !== a.salary) {
                return b.salary - a.salary;
            } else {
                return a.name.localeCompare(b.name);
            }
        });

        const formattedEmployees = sortedEmployees.map(emp => `${emp.name} ${emp.salary} ${emp.position}`).join("\n");

        return `Best Department is: ${bestDepartmentName}
Average salary: ${maxAverageSalary.toFixed(2)}
${formattedEmployees}`;
    }
}

// Example usage:
let c = new Company();
c.addEmployee("Stanimir", 2000, "engineer", "Construction");
c.addEmployee("Pesho", 1500, "electrical engineer", "Construction");
c.addEmployee("Slavi", 500, "dyer", "Construction");
c.addEmployee("Stan", 2000, "architect", "Construction");
c.addEmployee("Stanimir", 1200, "digital marketing manager", "Marketing");
c.addEmployee("Pesho", 1000, "graphical designer", "Marketing");
c.addEmployee("Gosho", 1350, "HR", "Human resources");
console.log(c.bestDepartment());
console.log();


