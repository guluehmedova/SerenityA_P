namespace Smt.Default {
    export enum Status {
        InProcess = 1,
        Solved = 2,
        Completed = 3,
        Rejected = 4
    }
    Serenity.Decorators.registerEnumType(Status, 'Smt.Default.Status');
}
