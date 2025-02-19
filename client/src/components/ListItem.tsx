export default function ListItem() {
  return (
    <li className="py-4 flex">
      <img className="h-10 w-10 rounded-full" alt="" />
      <div className="ml-3">
        <p className="text-sm font-medium text-gray-900">EVENT</p>
        <p className="text-sm text-gray-500">Albany</p>
      </div>
    </li>
  );
}
